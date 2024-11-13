
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium229";
        public override double halfLife { get; } = 3468.0d;
        public override double atomicWeight { get; } = 229.03351d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8d, new List<RadioactiveSubstance> { new BetaParticle(), new Protactinium229() } },

            { 0.2d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium225() } },

        };
    }
}
    
    