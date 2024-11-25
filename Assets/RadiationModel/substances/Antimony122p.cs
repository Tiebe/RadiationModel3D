using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony122p : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony122p";
        public override double halfLife { get; } = 251.46d;
        public override double atomicWeight { get; } = 121.90534d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony122() }, { 3.2851999999999996e-05d, new GammaParticle(26086.7, 0.04753) }, { 0.5539000000000001d, new GammaParticle(61413.0, 0.02019) }, { 0.23302d, new GammaParticle(76059.5, 0.0163) }, { 0.1451587807706d, new GammaParticle(3941.0, 0.3146) }, { 0.21375870042184184d, new GammaParticle(26111.0, 0.04748) }, { 0.39910138241568677d, new GammaParticle(26359.0, 0.04704) }, { 0.11353398054885781d, new GammaParticle(29821.0, 0.04158) }, { 0.1370355145224714d, new GammaParticle(30069.0, 0.04123) }, { 0.02350153397361357d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    