using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony134m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony134m";
        public override double halfLife { get; } = 10.07d;
        public override double atomicWeight { get; } = 133.92084d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium134()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.49d, new GammaParticle(115200.0, 0.01076)), new(0.97d, new GammaParticle(297000.0, 0.00417)), new(0.015d, new GammaParticle(329300.0, 0.00377)), new(0.57d, new GammaParticle(706300.0, 0.00176)), new(0.004d, new GammaParticle(822000.0, 0.00151)), new(0.023d, new GammaParticle(1151600.0, 0.00108)), new(1.0d, new GammaParticle(1279100.0, 0.00097)), new(0.0417830751038d, new GammaParticle(4135.0, 0.29984)), new(0.10093362468905219d, new GammaParticle(27202.0, 0.04558)), new(0.18795833275428714d, new GammaParticle(27473.0, 0.04513)), new(0.053790400621742555d, new GammaParticle(31093.0, 0.03988)), new(0.0654629175566607d, new GammaParticle(31359.0, 0.03954)), new(0.011672516934918135d, new GammaParticle(31698.0, 0.03911)) } },
            { 0.0008799999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium134()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.49d, new GammaParticle(115200.0, 0.01076)), new(0.97d, new GammaParticle(297000.0, 0.00417)), new(0.015d, new GammaParticle(329300.0, 0.00377)), new(0.57d, new GammaParticle(706300.0, 0.00176)), new(0.004d, new GammaParticle(822000.0, 0.00151)), new(0.023d, new GammaParticle(1151600.0, 0.00108)), new(1.0d, new GammaParticle(1279100.0, 0.00097)), new(0.0417830751038d, new GammaParticle(4135.0, 0.29984)), new(0.10093362468905219d, new GammaParticle(27202.0, 0.04558)), new(0.18795833275428714d, new GammaParticle(27473.0, 0.04513)), new(0.053790400621742555d, new GammaParticle(31093.0, 0.03988)), new(0.0654629175566607d, new GammaParticle(31359.0, 0.03954)), new(0.011672516934918135d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    