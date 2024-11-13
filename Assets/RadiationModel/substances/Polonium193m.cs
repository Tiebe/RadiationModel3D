
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium193m";
        public override double halfLife { get; } = 0.245d;
        public override double atomicWeight { get; } = 192.99117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead189() } },

        };
    }
}
    
    