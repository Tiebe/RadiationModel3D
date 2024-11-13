
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium155n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium155n";
        public override double halfLife { get; } = 0.00269d;
        public override double atomicWeight { get; } = 154.95624d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thulium151() } },

        };
    }
}
    
    