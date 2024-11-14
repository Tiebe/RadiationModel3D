using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine51 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine51";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 51.01534d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    