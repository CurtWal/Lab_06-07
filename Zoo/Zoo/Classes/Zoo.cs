using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes{
    public abstract class Zoo{
        public abstract string Name {get; set; }
        public abstract string Food {get; set; }
        public abstract string Sleep{get; set;}
        public abstract string Sound {get; set; }

        public abstract void AnimalSound();
        public abstract void RestTime();
        public abstract void FavoriteFood( );
    }
    
}