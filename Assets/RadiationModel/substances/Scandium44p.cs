using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium44p : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44p";
        public override double halfLife { get; } = 210996.0d;
        public override double atomicWeight { get; } = 43.95969d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9876999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium44()), new(0.8672d, new GammaParticle(271251.0, 0.00457)), new(0.0004917181720247999d, new GammaParticle(422.0, 2.93801)), new(0.006311281497435033d, new GammaParticle(4086.0, 0.30344)), new(0.012450742744989213d, new GammaParticle(4091.0, 0.30307)), new(0.002474710997575758d, new GammaParticle(4474.0, 0.27712)), new(0.002474710997575758d, new GammaParticle(4474.0, 0.27712)) } },
            { 0.0123d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium44()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0123d, new GammaParticle(1001876.0, 0.00124)), new(0.0123d, new GammaParticle(1126084.0, 0.0011)), new(0.0123d, new GammaParticle(1157002.0, 0.00107)), new(4.19642986568637e-05d, new GammaParticle(358.0, 3.46325)), new(0.0005557343660840703d, new GammaParticle(3688.0, 0.33618)), new(0.001098072250709485d, new GammaParticle(3692.0, 0.33582)), new(0.00021433333753644477d, new GammaParticle(4013.0, 0.30896)), new(0.00021433333753644477d, new GammaParticle(4013.0, 0.30896)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    