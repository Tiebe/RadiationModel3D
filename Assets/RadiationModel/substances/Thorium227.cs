
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium227";
        public override double halfLife { get; } = 1615075.2d;
        public override double atomicWeight { get; } = 227.0277d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radium223() } },

        };
    }
}
    
    