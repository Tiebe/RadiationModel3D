using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium104";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 103.92945d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium104()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.017079999999999998d, new GammaParticle(37400.0, 0.03315)), new(0.00549d, new GammaParticle(49900.0, 0.02485)), new(0.01403d, new GammaParticle(61100.0, 0.02029)), new(0.061d, new GammaParticle(100900.0, 0.01229)), new(0.01464d, new GammaParticle(140900.0, 0.0088)), new(0.017689999999999997d, new GammaParticle(202400.0, 0.00613)), new(0.02196d, new GammaParticle(210500.0, 0.00589)), new(0.03233d, new GammaParticle(213000.0, 0.00582)), new(0.01647d, new GammaParticle(241900.0, 0.00513)), new(0.00976d, new GammaParticle(250600.0, 0.00495)), new(0.041479999999999996d, new GammaParticle(263700.0, 0.0047)), new(0.00549d, new GammaParticle(274200.0, 0.00452)), new(0.054900000000000004d, new GammaParticle(445000.0, 0.00279)), new(0.054900000000000004d, new GammaParticle(504700.0, 0.00246)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    