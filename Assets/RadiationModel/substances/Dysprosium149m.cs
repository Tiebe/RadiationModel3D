using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium149m";
        public override double halfLife { get; } = 0.49d;
        public override double atomicWeight { get; } = 148.93018d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.993d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium149()), new(0.035d, new GammaParticle(110800.0, 0.01119)), new(0.932d, new GammaParticle(298600.0, 0.00415)), new(0.9875d, new GammaParticle(1073200.0, 0.00116)), new(0.9908d, new GammaParticle(1178600.0, 0.00105)), new(0.15563127461448d, new GammaParticle(7384.0, 0.16791)), new(0.04268770340263481d, new GammaParticle(45207.0, 0.02743)), new(0.07628252931135597d, new GammaParticle(45998.0, 0.02695)), new(0.02449276060794382d, new GammaParticle(52220.0, 0.02374)), new(0.03086087836600921d, new GammaParticle(52791.0, 0.02349)), new(0.006368117758065392d, new GammaParticle(53478.0, 0.02318)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium149()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0084d, new GammaParticle(290600.0, 0.00427)), new(0.0084d, new GammaParticle(361000.0, 0.00343)), new(0.006999999999999999d, new GammaParticle(559600.0, 0.00222)), new(0.006999999999999999d, new GammaParticle(630400.0, 0.00197)), new(0.0084d, new GammaParticle(786500.0, 0.00158)), new(0.006d, new GammaParticle(511000.0, 0.00243)), new(0.00076216870506d, new GammaParticle(7118.0, 0.17418)), new(0.00108306261107423d, new GammaParticle(43743.0, 0.02834)), new(0.0019420165161811549d, new GammaParticle(44481.0, 0.02787)), new(0.0006201532349043804d, new GammaParticle(50494.0, 0.02455)), new(0.0007807729227446149d, new GammaParticle(51040.0, 0.02429)), new(0.00016061968784023453d, new GammaParticle(51699.0, 0.02398)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    