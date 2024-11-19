using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium156m";
        public override double halfLife { get; } = 0.198d;
        public override double atomicWeight { get; } = 155.95311d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6637002.09), new Thulium152() } },

        };
    }
}
    
    