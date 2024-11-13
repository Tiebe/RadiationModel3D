
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium186m";
        public override double halfLife { get; } = 6912.0d;
        public override double atomicWeight { get; } = 185.95795d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.75d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium186() } },

            { 0.25d, new List<RadioactiveSubstance> { new GammaParticle(), new Iridium186() } },

        };
    }
}
    
    