using PizzaStoreApp.Exceptions;
using PizzaStoreApp.Interfaces;
using PizzaStoreApp.Models;
using PIzzaStoreModelLibrary;

namespace PizzaStoreApp.Services
{
    public class PizzaServicecs : IPizzaService, IManagePizzaService
    {
        private readonly IRepository<int, PizzaWithPic> _repository;

        public PizzaServicecs(IRepository<int,PizzaWithPic> repository) {
            _repository = repository;
        }
        public PizzaWithPic AddPizza(PizzaWithPic pizza)
        {
            pizza.Pic = "/images/" + pizza.Pic;
            var result = _repository.Add(pizza);
            return result;
            
        }

        public ICollection<PizzaWithPic> GetAllPizzas()
        {
            return _repository.GetAll();
        }
        #region GetPizzaByType
        /// <summary>
        /// This method will get the pizzas of the type that you provide(Veg/Non-Veg)
        /// </summary>
        /// <param name="type">Veg/Non-Veg</param>
        /// <returns></returns>
        /// <exception cref="PizzaStackEmptyException"></exception>
        /// <exception cref="InvalidPizzaTypeException"></exception>
        public ICollection<PizzaWithPic> GetPizzaByType(string type)
        {
            var pizzas = _repository.GetAll();
            if (type == "Veg" || type == "Non-Veg")
            {
                var typeSpecificPizza = pizzas.Where(p => p.Type == type).ToList();
                if (typeSpecificPizza.Count == 0)
                    throw new PizzaStackEmptyException();
                return typeSpecificPizza;
            }
            throw new InvalidPizzaTypeException();
        }
        #endregion

        #region GetPizzaWithRange
        /// <summary>
        /// Given the range gets all teh pizza within teh range
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="PizzaStackEmptyException"></exception>
        /// <exception cref="InValidPizzaPriceRangeException"></exception>
        public ICollection<PizzaWithPic> GetPizzasByRange(int min, int max)
        {
            var pizzas = _repository.GetAll();
            if (min >= 00 || max > 0)
            {
                var pizzasInRange = pizzas.Where(p => p.Price >= min && p.Price <= max).ToList();
                if (pizzasInRange.Count == 0)
                    throw new PizzaStackEmptyException();
                return pizzasInRange;
            }
            throw new InValidPizzaPriceRangeException();
        }
        #endregion

        #region UpdatePizzaPrice
        /// <summary>
        /// Update the pice of the pizza
        /// </summary>
        /// <param name="pizza">the pizza object with the updated price and id</param>
        /// <returns>Updated pizza object</returns>
        /// <exception cref="PizzaStackEmptyException"></exception>
        public PizzaWithPic UpdatePizzaPrice(PizzaWithPic pizza)
        {
            var myPizza = _repository.GetById(pizza.Id);
            if (myPizza == null)
                throw new PizzaStackEmptyException();
            myPizza.Price = pizza.Price;
            myPizza = _repository.Update(myPizza);
            return myPizza;
        }
        #endregion

        #region UpdatePizzaQuantity
        /// <summary>
        /// Updats quantity of the pizza
        /// </summary>
        /// <param name="pizza">the pizza object with the updated quantity and id</param>
        /// <returns>Updated pizza object</returns>
        /// <exception cref="PizzaStackEmptyException"></exception>
        public PizzaWithPic UpdatePizzaQuantity(PizzaWithPic pizza)
        {
            var myPizza = _repository.GetById(pizza.Id);
            if (myPizza == null)
                throw new PizzaStackEmptyException();
            myPizza.Quantity = pizza.Quantity;
            myPizza = _repository.Update(myPizza);
            return myPizza;
        }
        #endregion
    }
}
