namespace PIzzaStoreModelLibrary
{
    public class Pizza: IEquatable<Pizza>, IComparable<Pizza>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? Type { get; set; }

        #region PizzaToStringMethod

        /// <summary>
        /// When reff of Pizza object is used for printing this method will print the details of
        /// the properties
        /// </summary>
        /// <returns>Stringtaht hold details of pizza name,pricenquantity and type</returns>
        public override string ToString()
        {
            return $"Pizza Id : {Id} \n " +
                $"Pizza Name : {Name} \n" +
                $"Pizza Price : Rs.{Price} \n" +
                $"Pizza Quantity : {Quantity} \n" +
                $"Pizza Type : {Type}";
        }
        #endregion

        #region PizzaEqualsMethod
        /// <summary>
        /// Checks if 2 Pizza objects are equal basedon the ID of the Pizza
        /// </summary>
        /// <param name="other">Takes the pizza object that has to be compares</param>
        /// <returns>Will be true if teh Ids are same otherwise false</returns>
        public virtual bool Equals(Pizza? other)
        {
            Pizza p1, p2;
            p1 = other??new Pizza();//If parameter is null then it will create a new object
            p2 = this;
            if (p1.Id == p2.Id)
                return true;
            return false;
        }
        #endregion

        #region PizzaCompareToMethod
        /// <summary>
        /// Method that is called while teh objects are sorted
        /// </summary>
        /// <param name="other">Pizza object that has to be compared gets passed</param>
        /// <returns>integer based on the id of the pizza is greater or not</returns>
        public int CompareTo(Pizza? other)
        {
            Pizza p1, p2;
            p1 = this;
            p2 = other??new Pizza();
            return p1.Id.CompareTo(p2.Id);
        }
        #endregion
    }
}