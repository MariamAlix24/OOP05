namespace G_NET_99_OOP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Question1
            //a)You copy the reference (memory address) of the object, not the object itself. Both variables now point to the exact same object in memory.
            //b)No. No new memory is allocated on the heap. Any change made through one variable will affect the other because both refer to the same underlying object.
            /*c)Copying a reference: Copies only the memory pointer. Both variables share and modify the same instance.
            Copying an object (Cloning): Creates a brand-new instance in memory with duplicate data. Modifying the new object does not affect the original.*/
            #endregion
            #region Question2
            //a)A bitwise copy of an object. It copies all value-type fields directly, but for reference-type fields, it only copies their memory addresses.
            //b)A complete copy of an object along with all nested objects it references. It creates fully independent duplicates at every level of the object hierarchy.
            //c)Both the original and copied objects share the exact same reference-type instances. Modifying a reference member in one object will automatically affect the other.
            //d)Brand-new instances of the reference-type members are allocated in memory. The original and copied objects hold separate references, making them completely isolated from each other.
            //e)When an object contains mutable reference-type fields (such as a list or custom class) that will be modified independently—like cloning a user profile with an editable list of items—without risking accidental side effects on the original object.
            #endregion
            #region Question3
            //a)A static field belongs to the class itself and is shared across all instances. An instance field belongs to a specific object, meaning every created instance gets its own separate copy.
            //b)A static method belongs to the class and can be invoked without creating an instance. No, it cannot directly access instance members because it operates without a specific object reference (this).
            //c)A parameterless block used to initialize static data or perform one-time setup. It is executed automatically once before the first instance is created or any static member is accessed.
            //d)A class that contains only static members and cannot be instantiated or inherited. No, you cannot create an object from it using the new keyword.
            #endregion
            #endregion
        }
    }
}
