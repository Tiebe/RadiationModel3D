using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony129m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony129m";
        public override double halfLife { get; } = 1062.0d;
        public override double atomicWeight { get; } = 128.91113d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium129()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.051d, new GammaParticle(130900.0, 0.00947)), new(0.62d, new GammaParticle(433760.0, 0.00286)), new(0.78d, new GammaParticle(657780.0, 0.00188)), new(0.85d, new GammaParticle(759800.0, 0.00163)), new(0.034d, new GammaParticle(788700.0, 0.00157)), new(0.0018558818451600001d, new GammaParticle(4135.0, 0.29984)), new(0.00510563729595782d, new GammaParticle(27202.0, 0.04558)), new(0.009507704461746404d, new GammaParticle(27473.0, 0.04513)), new(0.002720939393833835d, new GammaParticle(31093.0, 0.03988)), new(0.0033113832422957774d, new GammaParticle(31359.0, 0.03954)), new(0.0005904438484619422d, new GammaParticle(31698.0, 0.03911)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony129()), new(0.1422d, new GammaParticle(722690.0, 0.00172)), new(0.15d, new GammaParticle(1128600.0, 0.0011)), new(0.0005600983554d, new GammaParticle(3941.0, 0.3146)), new(0.0016078980859455794d, new GammaParticle(26111.0, 0.04748)), new(0.0030020501978072806d, new GammaParticle(26359.0, 0.04704)), new(0.0008540053324334214d, new GammaParticle(29821.0, 0.04158)), new(0.0010307844362471396d, new GammaParticle(30069.0, 0.04123)), new(0.00017677910381371824d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    