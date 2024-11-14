using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine108 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine108";
        public override double halfLife { get; } = 0.0264d;
        public override double atomicWeight { get; } = 107.94335d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new List<RadioactiveSubstance> { new AlphaParticle(5125047.4), new Antimony104() } },
            { 0.005d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tellurium107() } },

        };
    }
}
    
    