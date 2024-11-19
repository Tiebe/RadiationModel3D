using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium213";
        public override double halfLife { get; } = 163.8d;
        public override double atomicWeight { get; } = 213.00037d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new AlphaParticle(7884002.09), new Radon209() } },
            { 0.13d, new List<RadioactiveSubstance> { new BetaParticle(1, 3900000.0), new Francium213() } },

        };
    }
}
    
    