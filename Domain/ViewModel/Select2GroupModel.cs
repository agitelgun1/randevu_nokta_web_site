using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    public class Select2GroupModel
    {
        public Select2GroupModel()
        {
            children = new List<Select2Model>();
        }

        public string text { get; set; }
        public List<Select2Model> children { get; set; }
    }

    public class Select2Model
    {
        public int id { get; set; }
        public string text { get; set; }
    }

    public class Select2GroupResponse
    {
        public Select2GroupResponse()
        {
            results = new List<Select2GroupModel>();
            paginate = new Pagination();
        }

        public List<Select2GroupModel> results { get; set; }
        public Pagination paginate { get; set; }
    }

    public class Pagination
    {
        public bool more { get; set; }
    }

}
