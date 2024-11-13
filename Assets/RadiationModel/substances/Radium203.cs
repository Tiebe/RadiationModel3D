
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium203 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium203";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 203.00923d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon199() } },

        };
    }
}
    
    