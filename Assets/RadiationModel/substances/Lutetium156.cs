using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium156";
        public override double halfLife { get; } = 0.494d;
        public override double atomicWeight { get; } = 155.95309d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6617002.09), new Thulium152() } },

        };
    }
}
    
    