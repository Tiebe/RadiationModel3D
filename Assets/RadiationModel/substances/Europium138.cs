
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium138";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 137.93371d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    