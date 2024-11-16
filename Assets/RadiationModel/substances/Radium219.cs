using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 219.01008d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9160002.09), new Radon215() } },

        };
    }
}
    
    