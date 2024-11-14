using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine52 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine52";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 52.024d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    