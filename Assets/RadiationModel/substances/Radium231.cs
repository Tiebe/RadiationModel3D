
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium231";
        public override double halfLife { get; } = 104.0d;
        public override double atomicWeight { get; } = 231.04103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Actinium231() } },

        };
    }
}
    
    