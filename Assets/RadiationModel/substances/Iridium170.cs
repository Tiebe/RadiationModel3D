
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium170";
        public override double halfLife { get; } = 0.91d;
        public override double atomicWeight { get; } = 169.97512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.052000000000000005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium166() } },

        };
    }
}
    
    