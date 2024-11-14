using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium237";
        public override double halfLife { get; } = 3943296.0d;
        public override double atomicWeight { get; } = 237.04841d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999958d, new List<RadioactiveSubstance> { new Neptunium237() } },
            { 4.2e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6767647.399999999), new Uranium233() } },

        };
    }
}
    
    