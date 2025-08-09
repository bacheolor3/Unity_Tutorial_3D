using System.Collections;
using UnityEngine;

public class PizzaController : MonoBehaviour
{
    private IEnumerator Start()
    {
        PizzaStore pizzastore = null;
        Pizza pizza = null;

        pizzastore = new LegacyPizzaStore();
        pizza = pizzastore.OrderPizza("Normal");
        Debug.Log($"Ordered {pizza} are served");

        yield return new WaitForSeconds(1f);
        pizza = pizzastore.OrderPizza("Speical");
        Debug.Log($"Ordered {pizza} are served");

        yield return new WaitForSeconds(1f);

        pizzastore = new NewPizzaStore();
        pizza = pizzastore.OrderPizza("Normal");
        Debug.Log($"Ordered {pizza} are served");

        yield return new WaitForSeconds(1f);
        pizza = pizzastore.OrderPizza("Special");
        Debug.Log($"Ordered {pizza} are served");
    }
}
