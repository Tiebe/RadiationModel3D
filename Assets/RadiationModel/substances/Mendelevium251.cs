
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium251";
        public override double halfLife { get; } = 252.6d;
        public override double atomicWeight { get; } = 251.08477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium247() } },

        };
    }
}
    
    