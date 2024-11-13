
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium212";
        public override double halfLife { get; } = 1200.0d;
        public override double atomicWeight { get; } = 211.99623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.57d, new List<RadioactiveSubstance> { new BetaParticle(), new Radon212() } },

            { 0.43d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine208() } },

        };
    }
}
    
    