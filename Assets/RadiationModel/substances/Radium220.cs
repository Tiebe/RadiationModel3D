
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium220";
        public override double halfLife { get; } = 0.0181d;
        public override double atomicWeight { get; } = 220.01103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon216() } },

        };
    }
}
    
    