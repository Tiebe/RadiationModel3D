
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium224";
        public override double halfLife { get; } = 10008.0d;
        public override double atomicWeight { get; } = 224.02172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.905d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium224() } },

            { 0.095d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium220() } },

        };
    }
}
    
    