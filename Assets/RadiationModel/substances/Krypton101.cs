using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton101 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton101";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 100.96932d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    