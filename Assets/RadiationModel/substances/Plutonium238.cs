using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium238";
        public override double halfLife { get; } = 2767544690.4d;
        public override double atomicWeight { get; } = 238.04956d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6613147.399999999), new Uranium234() } },
            { 1.9e-09d, new List<RadioactiveSubstance> {  } },
            { 1.4e-16d, new List<RadioactiveSubstance> { new Silicon32(), new Mercury206() } },
            { 6e-17d, new List<RadioactiveSubstance> { new Magnesium28(), new Magnesium30(), new Ytterbium180() } },

        };
    }
}
    
    