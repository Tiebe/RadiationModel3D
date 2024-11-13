
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium174";
        public override double halfLife { get; } = 7.9d;
        public override double atomicWeight { get; } = 173.96695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.995d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium174() } },

            { 0.005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium170() } },

        };
    }
}
    
    