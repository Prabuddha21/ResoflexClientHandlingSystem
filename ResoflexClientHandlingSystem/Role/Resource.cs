using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Resource
    {
        private int resourceId;
        private string name;
        private float value;
        private int totalQty;
        private int availableQty;

        public Resource()
        {
        }

        public Resource(int resourceId, string name, float value, int totalQty, int availableQty)
        {
            this.ResourceId = resourceId;
            this.Name = name;
            this.Value = value;
            this.TotalQty = totalQty;
            this.AvailableQty = availableQty;
        }

        public Resource(string name, float value, int totalQty, int availableQty)
        {
            this.Name = name;
            this.Value = value;
            this.TotalQty = totalQty;
            this.AvailableQty = availableQty;
            this.Name = name;
            this.Value = value;
            this.TotalQty = totalQty;
            this.AvailableQty = availableQty;
        }
        
        public Resource(int resourceId, int totalQty)
        {
            this.resourceId = resourceId;
            this.totalQty = totalQty;
        }

        public int ResourceId { get => resourceId; set => resourceId = value; }
        public string Name { get => name; set => name = value; }
        public float Value { get => value; set => this.value = value; }
        public int TotalQty { get => totalQty; set => totalQty = value; }
        public int AvailableQty { get => availableQty; set => availableQty = value; }
    }
}
