using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium130m";
        public override double halfLife { get; } = 0.0094d;
        public override double atomicWeight { get; } = 129.90898d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium130()), new(0.06465499999999999d, new GammaParticle(80300.0, 0.01544)), new(0.965d, new GammaParticle(357200.0, 0.00347)), new(0.02895d, new GammaParticle(420300.0, 0.00295)), new(0.02895d, new GammaParticle(452500.0, 0.00274)), new(0.12545d, new GammaParticle(463100.0, 0.00268)), new(0.82025d, new GammaParticle(544500.0, 0.00228)), new(0.019299999999999998d, new GammaParticle(551100.0, 0.00225)), new(0.06755d, new GammaParticle(652500.0, 0.0019)), new(0.7334d, new GammaParticle(691100.0, 0.00179)), new(0.08685000000000001d, new GammaParticle(802900.0, 0.00154)), new(0.6369d, new GammaParticle(883000.0, 0.0014)), new(0.009649999999999999d, new GammaParticle(908300.0, 0.00137)), new(0.04825d, new GammaParticle(1004000.0, 0.00123)), new(0.024125d, new GammaParticle(1111000.0, 0.00112)), new(0.006801289166320001d, new GammaParticle(4966.0, 0.24967)), new(0.015151972051080423d, new GammaParticle(31816.0, 0.03897)), new(0.0279144658273405d, new GammaParticle(32193.0, 0.03851)), new(0.008210829649823542d, new GammaParticle(36482.0, 0.03399)), new(0.010279958721579075d, new GammaParticle(36827.0, 0.03367)), new(0.0020691290717555324d, new GammaParticle(37255.0, 0.03328)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    