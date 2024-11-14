using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium227";
        public override double halfLife { get; } = 2298.0d;
        public override double atomicWeight { get; } = 227.0288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new AlphaParticle(7600047.4), new Actinium223() } },
            { 0.15d, new List<RadioactiveSubstance> { new Thorium227() } },

        };
    }
}
    
    