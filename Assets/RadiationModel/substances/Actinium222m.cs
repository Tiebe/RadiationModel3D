
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium222m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium222m";
        public override double halfLife { get; } = 63.0d;
        public override double atomicWeight { get; } = 222.01793d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.986d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium218() } },

            { 0.013999999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium222() } },

        };
    }
}
    
    