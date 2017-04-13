using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.VisaNS;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using static System.Linq.Enumerable;

namespace Red303340
{
    public partial class FindResrouce : Form
    {
        private string filter;
        private TreeNode ndGpib;
        private TreeNode ndVxi;
        private TreeNode ndGpibVxi;
        private TreeNode ndSerial;
        private TreeNode ndPxi;
        private TreeNode ndTcpip;
        private TreeNode ndUSB;
        private TreeNode ndFireWire;
        private bool ndTcpipAdded = false;

        public FindResrouce()
        {
            InitializeComponent();
            ndGpib = new TreeNode("GPIB");
            ndVxi = new TreeNode("VXI");
            ndGpibVxi = new TreeNode("GPIB VXI");
            ndSerial = new TreeNode("Serial");
            ndPxi = new TreeNode("PXI");
            ndTcpip = new TreeNode("TCP/IP");
            ndUSB = new TreeNode("USB");
            ndFireWire = new TreeNode("FireWire");
            CleanResourceNodes();

            PopulateFilterList();
        }

        private void findResourcesButton_Click(object sender, EventArgs e)
        {
            filter = filterStringsListBox.Text;
            DisplayResources();
        }
        private void DisplayResources()
        {
            resourceTreeView.Nodes.Clear();
            ndTcpipAdded = false;
            CleanResourceNodes();
            FindResources();
            resourceTreeView.ExpandAll();
        }
        private void CleanResourceNodes()
        {
            ndGpib.Nodes.Clear();
            ndVxi.Nodes.Clear();
            ndGpibVxi.Nodes.Clear();
            ndSerial.Nodes.Clear();
            ndPxi.Nodes.Clear();
            ndTcpip.Nodes.Clear();
            ndUSB.Nodes.Clear();
            ndFireWire.Nodes.Clear();
        }
        private void FindResources()
        {
            try
            {
                string[] resources = ResourceManager.GetLocalManager().FindResources(filter);

                if (resources.Length == 0)
                {
                    MessageBox.Show("There was no resource found on your system.");
                }

                foreach (string s in resources)
                {
                    HardwareInterfaceType intType;
                    short intNum;
                    ResourceManager.GetLocalManager().ParseResource(s, out intType, out intNum);
                    AddToResourceNode(s, intType);
                }
                AddToResourceTree();
            }
            catch (VisaException)
            {
                // Don't do anything
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddToResourceNode(string resourceName, HardwareInterfaceType intType)
        {
            switch (intType)
            {
                case HardwareInterfaceType.Gpib:
                    ndGpib.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.Vxi:
                    ndVxi.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.GpibVxi:
                    ndGpibVxi.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.Serial:
                    ndSerial.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.Pxi:
                    ndPxi.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.Tcpip:
                    ndTcpip.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.Usb:
                    ndUSB.Nodes.Add(new TreeNode(resourceName));
                    break;
                case HardwareInterfaceType.Firewire:
                    ndFireWire.Nodes.Add(new TreeNode(resourceName));
                    break;
                default:
                    break;
            }
        }
        private void AddToResourceTree()
        {
            if (ndGpib.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndGpib);
            if (ndVxi.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndVxi);
            if (ndGpibVxi.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndGpibVxi);
            if (ndSerial.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndSerial);
            if (ndPxi.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndPxi);
            if (ndUSB.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndUSB);
            if (ndFireWire.Nodes.Count != 0)
                resourceTreeView.Nodes.Add(ndFireWire);
        }
        private void PopulateFilterList()
        {
            filterStringsListBox.Items.Clear();
            filterStringsListBox.Items.Add("?*");
            filterStringsListBox.Items.Add("GPIB?*");
            filterStringsListBox.Items.Add("GPIB?*INSTR");
            filterStringsListBox.Items.Add("GPIB?*INTFC");
            filterStringsListBox.Items.Add("GPIB?*SERVANT");
            filterStringsListBox.Items.Add("GPIB-VXI?*");
            filterStringsListBox.Items.Add("GPIB-VXI?*INSTR");
            filterStringsListBox.Items.Add("GPIB-VXI?*MEMACC");
            filterStringsListBox.Items.Add("GPIB-VXI?*BACKPLANE");
            filterStringsListBox.Items.Add("PXI?*INSTR");
            filterStringsListBox.Items.Add("ASRL?*INSTR");
            filterStringsListBox.Items.Add("VXI?*");
            filterStringsListBox.Items.Add("VXI?*INSTR");
            filterStringsListBox.Items.Add("VXI?*MEMACC");
            filterStringsListBox.Items.Add("VXI?*BACKPLANE");
            filterStringsListBox.Items.Add("VXI?*SERVANT");
            filterStringsListBox.Items.Add("USB?*");
            filterStringsListBox.Items.Add("FIREWIRE?*");
            filterStringsListBox.SelectedIndex = 0;
        }
        private string ValidResourceName(string resourceName)
        {
            Session session = null;
            string fullName = null;
            try
            {
                
                session = ResourceManager.GetLocalManager().Open(resourceName);
                fullName = session.ResourceName;
            }
            catch (VisaException)
            {
                // Don't do anything
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

            if (session != null)
            {
                session.Dispose();
            }

            return fullName;
        }
        private void FindResrouce_Load(object sender, EventArgs e)
        {

        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
         
        public static IPAddress GetSubnetMask(IPAddress address)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.Equals(unicastIPAddressInformation.Address))
                        {
                            return unicastIPAddressInformation.IPv4Mask;
                        }
                    }
                }
            }
            throw new ArgumentException(string.Format("Can't find subnetmask for IP address '{0}'", address));
        }
        private void findTcpipResourcesButton_Click(object sender, EventArgs e)
        {
            string fullname = "";
            gvtConnectStringFrm newGetConnectStr = new gvtConnectStringFrm();
            DialogResult dr = newGetConnectStr.ShowDialog();
            if (dr == DialogResult.OK)
            {
                fullname=ValidResourceName(newGetConnectStr.GetMsg());
            }
            MessageBox.Show(fullname);
        }
    }
}
