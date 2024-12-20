using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium96";
        public override double halfLife { get; } = 369792.0d;
        public override double atomicWeight { get; } = 95.90787d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium96()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00039904000000000003d, new GammaParticle(120300.0, 0.01031)), new(0.00039904000000000003d, new GammaParticle(219400.0, 0.00565)), new(0.0007980800000000001d, new GammaParticle(241600.0, 0.00513)), new(0.02434144d, new GammaParticle(314270.0, 0.00395)), new(0.0139664d, new GammaParticle(316500.0, 0.00392)), new(0.0006983200000000001d, new GammaParticle(349900.0, 0.00354)), new(0.00019952000000000001d, new GammaParticle(350100.0, 0.00354)), new(0.00019952000000000001d, new GammaParticle(352500.0, 0.00352)), new(0.0006983200000000001d, new GammaParticle(371800.0, 0.00333)), new(0.007482d, new GammaParticle(434710.0, 0.00285)), new(0.004289680000000001d, new GammaParticle(460040.0, 0.0027)), new(0.0007980800000000001d, new GammaParticle(481000.0, 0.00258)), new(0.00409016d, new GammaParticle(535780.0, 0.00231)), new(0.009177920000000001d, new GammaParticle(568880.0, 0.00218)), new(0.00109736d, new GammaParticle(591300.0, 0.0021)), new(0.0019952d, new GammaParticle(719500.0, 0.00172)), new(0.00119712d, new GammaParticle(721500.0, 0.00172)), new(0.9976d, new GammaParticle(778220.0, 0.00159)), new(0.8200272d, new GammaParticle(812540.0, 0.00153)), new(0.00018954399999999999d, new GammaParticle(847700.0, 0.00146)), new(0.9756528d, new GammaParticle(849860.0, 0.00146)), new(0.0009976d, new GammaParticle(885400.0, 0.0014)), new(0.010973599999999998d, new GammaParticle(1091300.0, 0.00114)), new(0.1516352d, new GammaParticle(1126850.0, 0.0011)), new(0.00369112d, new GammaParticle(1200170.0, 0.00103)), new(0.000538704d, new GammaParticle(1441140.0, 0.00086)), new(0.000927768d, new GammaParticle(1497720.0, 0.00083)), new(9.975999999999999e-06d, new GammaParticle(1625700.0, 0.00076)), new(0.038d, new GammaParticle(2440.0, 0.50813)), new(0.18899999999999997d, new GammaParticle(17374.0, 0.07136)), new(0.361d, new GammaParticle(17479.0, 0.07093)), new(0.095d, new GammaParticle(19681.0, 0.063)), new(0.109d, new GammaParticle(19794.0, 0.06264)), new(0.0146d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    