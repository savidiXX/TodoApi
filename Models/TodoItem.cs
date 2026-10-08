namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id {get; set;}
        public String Title
        {
            get{return _title;}
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                throw new Exception("The Title cant be empty");
                _title = value;
            }
        }
        private string _title ="";
        public bool IsDone{get; set;}
    }

}