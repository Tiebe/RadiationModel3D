
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium239";
        public override double halfLife { get; } = 9000.0d;
        public override double atomicWeight { get; } = 239.05491d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Americium239() } },

            { 6.2e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium235() } },

        };
    }
}
    
    