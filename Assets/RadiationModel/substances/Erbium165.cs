
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium165";
        public override double halfLife { get; } = 37296.0d;
        public override double atomicWeight { get; } = 164.93073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Holmium165() } },

        };
    }
}
    
    