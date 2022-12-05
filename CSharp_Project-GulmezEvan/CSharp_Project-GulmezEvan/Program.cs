// See https://aka.ms/new-console-template for more information
using System.Collections;

//ArrayList

ArrayList uneCollection = new ArrayList();

uneCollection.Add(new object());

uneCollection.Insert(0, "TEST");

foreach (object o in uneCollection)
{
    if (o.GetType() == typeof(string))
    {

    }
}