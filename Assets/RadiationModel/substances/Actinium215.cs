
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium215";
        public override double halfLife { get; } = 0.171d;
        public override double atomicWeight { get; } = 215.00647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium211() } },

            { 0.0009d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium215() } },

        };
    }
}
    
    