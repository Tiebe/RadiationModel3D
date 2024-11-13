
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium179";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 178.96127d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    