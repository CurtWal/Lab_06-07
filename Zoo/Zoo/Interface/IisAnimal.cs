using System;
namespace Zoo.Interface
{
    public interface IisAnimal
    {
        /// <summary>
        /// Is this thing an animal
        /// </summary>

        string isAnAnimal { get; set; }

        ///<summary>
        ///Adjust the setting of the animal
        ///</summary>
        ///<returns>The settings of the animal</returns>
        string AdjustSettings();
    }
}