using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium163m";
        public override double halfLife { get; } = 23.5d;
        public override double atomicWeight { get; } = 162.93424d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    