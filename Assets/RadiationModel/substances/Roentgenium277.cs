using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium277";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 277.15932d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    