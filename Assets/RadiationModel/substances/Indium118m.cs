
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium118m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium118m";
        public override double halfLife { get; } = 261.84d;
        public override double atomicWeight { get; } = 117.90646d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin118() } },

        };
    }
}
    
    