using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium222";
        public override double halfLife { get; } = 33.6d;
        public override double atomicWeight { get; } = 222.01537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7699602.09), new Radon218() } },
            { 3e-10d, new List<RadioactiveSubstance> { new Carbon14(), new Lead208() } },

        };
    }
}
    
    