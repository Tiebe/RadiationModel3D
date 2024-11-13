
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium227";
        public override double halfLife { get; } = 66.0d;
        public override double atomicWeight { get; } = 227.03118d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium223() } },

        };
    }
}
    
    