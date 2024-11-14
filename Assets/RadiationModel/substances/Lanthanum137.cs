using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum137 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum137";
        public override double halfLife { get; } = 1893417120000.0d;
        public override double atomicWeight { get; } = 136.90645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Barium137() } },

        };
    }
}
    
    