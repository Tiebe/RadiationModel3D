
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon193 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon193";
        public override double halfLife { get; } = 0.00115d;
        public override double atomicWeight { get; } = 193.00971d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Polonium189() } },

        };
    }
}
    
    