using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium97";
        public override double halfLife { get; } = 244512.0d;
        public override double atomicWeight { get; } = 96.90755d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum97()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00119868d, new GammaParticle(108790.0, 0.0114)), new(1.7124e-05d, new GammaParticle(114400.0, 0.01084)), new(4.62348e-05d, new GammaParticle(185000.0, 0.0067)), new(0.8562000000000001d, new GammaParticle(215700.0, 0.00575)), new(0.1078812d, new GammaParticle(324490.0, 0.00382)), new(0.001207242d, new GammaParticle(460560.0, 0.00269)), new(1.9692600000000002e-05d, new GammaParticle(483760.0, 0.00256)), new(2.65422e-05d, new GammaParticle(531060.0, 0.00233)), new(0.00032535599999999995d, new GammaParticle(560340.0, 0.00221)), new(0.00873324d, new GammaParticle(569290.0, 0.00218)), new(8.390760000000001e-05d, new GammaParticle(639720.0, 0.00194)), new(0.0006164639999999999d, new GammaParticle(645230.0, 0.00192)), new(8.562e-05d, new GammaParticle(670210.0, 0.00185)), new(0.000753456d, new GammaParticle(753990.0, 0.00164)), new(0.0007192079999999999d, new GammaParticle(785050.0, 0.00158)), new(1.36992e-05d, new GammaParticle(850100.0, 0.00146)), new(0.0004281d, new GammaParticle(855440.0, 0.00145)), new(1.7980200000000001e-06d, new GammaParticle(898080.0, 0.00138)), new(7.96266e-06d, new GammaParticle(969650.0, 0.00128)), new(0.042404697427529864d, new GammaParticle(2586.0, 0.47944)), new(0.2010989367201817d, new GammaParticle(18250.0, 0.06794)), new(0.38239006792200364d, new GammaParticle(18367.0, 0.0675)), new(0.10163189312290916d, new GammaParticle(20695.0, 0.05991)), new(0.1176897322363288d, new GammaParticle(20820.0, 0.05955)), new(0.016057839113419646d, new GammaParticle(21003.0, 0.05903)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    