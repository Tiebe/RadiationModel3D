
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium222";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 222.01784d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium218() } },

            { 0.01d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium222() } },

        };
    }
}
    
    