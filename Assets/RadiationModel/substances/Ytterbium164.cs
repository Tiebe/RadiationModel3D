using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium164";
        public override double halfLife { get; } = 4548.0d;
        public override double atomicWeight { get; } = 163.9345d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Thulium164() } },

        };
    }
}
    
    