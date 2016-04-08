public class Animal {
    // Simple properties
    public double speed { get; set; }
    public string origin { get; set; }
    public int legs { get; set; }
    public string name { get; set; }
    public virtual bool warmblood = true;
    public string mainPrey { get; set; } 
    // Public method that can be redefined by derived classes
    public virtual void walk () {
        Console.WriteLine("Animal class walk method");
        speed = speed + (0.1 * legs);
    }
    public string humanBenefits { get; set; }
    public string funFact { get; set; }
}
//Genus///////////////
class Canis : Animal {
    public bool isDomesticated = false;
}
// Species
class Coyote : Canis {
    public Coyote (string sound) {
        Noise = sound;
    }
}
// Species
class GrayWolf : Canis {
    public GrayWolf (string sound) {
        Noise = sound;
    }    
}
// Species
class Dog : Canis {
    public Dog (string sound) {
        Noise = sound;
    }
    public Dog (string sound, string breed) {
        Noise = sound;
        Type = breed;
    }    
}

//Genus/////////////////
class Felis : Animal {
    public bool isDomesticated = false;
}
// Species
class JungleCat : Felis {
    public JungleCat (string color){
        Flavor = color;
    }
}
// Species
class WildCat : Felis {
    
}
// Species
class Cat : Felis {
    public Cat (string sound) {
        Noise = sound;
    }
}

//Genus/////////////////
class Gekko : Animal {
    public bool camouflage { get; set; }
}
// Species
class PalmGecko : Gekko {}
// Species
class GreenEyedGecko : Gekko {}
// Species
class PekingGecko : Gekko {}   

//Genus///////////////// 
class Apis : Animal {
    private bool _hasWings = true;
    private bool _canFly = true;
    public virtual void flightSpeed () {
        Console.WriteLine("Apis class flightSpeed method");
        flyspeed = wingRatio + (0.1 * wingSpan);
    }
}
class HoneyBee : Apis {
    private bool _endangered = true;
}

class RedDwarfBee : Apis {
    private bool _endangered = false;
}

class GiantHoneyBee : Apis {
    private bool _endangered = true;
}

 // Genus/////////////////
class Falco : Animal {
    private bool _hasWings = true;
    private bool _canFly = true;
    public int flyspeed { get; set; }

    public virtual void flightSpeed (int wingRatio, int wingSpan) {
        Console.WriteLine("Falco class flightSpeed method");
        flyspeed = wingRatio + ( 2 * wingSpan);
    }
}
//Species
class BrownFalcon : Falco {
    public override void flightSpeed (int wingssize, int wingRatio) {
        flyspeed = wingRatio + ( 3 * wingSpan);
}
// Species
class NewZealandFalcon : Falco {
    public override void flightSpeed (int wingssize, int wingRatio) {
        flyspeed = wingRatio + (0.5 * wingSpan);
}

// Species
class SakerFalcon : Falco {
    public override void flightSpeed (int wingssize, int wingRatio) {
        flyspeed = wingRatio + (0.2 * wingSpan);
    }    
}
  




