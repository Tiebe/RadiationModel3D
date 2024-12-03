using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver117m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver117m";
        public override double halfLife { get; } = 5.34d;
        public override double atomicWeight { get; } = 116.91181d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium117()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.002052d, new GammaParticle(104700.0, 0.01184)), new(0.513d, new GammaParticle(135400.0, 0.00916)), new(0.049761d, new GammaParticle(142100.0, 0.00873)), new(0.066177d, new GammaParticle(157100.0, 0.00789)), new(0.066177d, new GammaParticle(184500.0, 0.00672)), new(0.0066690000000000004d, new GammaParticle(202200.0, 0.00613)), new(0.060021000000000005d, new GammaParticle(204600.0, 0.00606)), new(0.007181999999999999d, new GammaParticle(215300.0, 0.00576)), new(0.034371d, new GammaParticle(219700.0, 0.00564)), new(0.010773d, new GammaParticle(249500.0, 0.00497)), new(0.224181d, new GammaParticle(298100.0, 0.00416)), new(0.023597999999999997d, new GammaParticle(307200.0, 0.00404)), new(0.074385d, new GammaParticle(322100.0, 0.00385)), new(0.098496d, new GammaParticle(337700.0, 0.00367)), new(0.021546d, new GammaParticle(341100.0, 0.00363)), new(0.00513d, new GammaParticle(353100.0, 0.00351)), new(0.017955000000000002d, new GammaParticle(362300.0, 0.00342)), new(0.016416d, new GammaParticle(365400.0, 0.00339)), new(0.011798999999999999d, new GammaParticle(377600.0, 0.00328)), new(0.424764d, new GammaParticle(386800.0, 0.00321)), new(0.028727999999999997d, new GammaParticle(413800.0, 0.003)), new(0.023597999999999997d, new GammaParticle(421200.0, 0.00294)), new(0.013851d, new GammaParticle(442600.0, 0.0028)), new(0.021033d, new GammaParticle(482400.0, 0.00257)), new(0.009747d, new GammaParticle(486800.0, 0.00255)), new(0.01026d, new GammaParticle(492700.0, 0.00252)), new(0.010773d, new GammaParticle(500600.0, 0.00248)), new(0.099522d, new GammaParticle(522100.0, 0.00237)), new(0.013338000000000001d, new GammaParticle(526400.0, 0.00236)), new(0.007695d, new GammaParticle(529900.0, 0.00234)), new(0.003078d, new GammaParticle(543200.0, 0.00228)), new(0.0035909999999999996d, new GammaParticle(546500.0, 0.00227)), new(0.00513d, new GammaParticle(555200.0, 0.00223)), new(0.022059000000000002d, new GammaParticle(557800.0, 0.00222)), new(0.007181999999999999d, new GammaParticle(569900.0, 0.00218)), new(0.01026d, new GammaParticle(581900.0, 0.00213)), new(0.003078d, new GammaParticle(585400.0, 0.00212)), new(0.003078d, new GammaParticle(591900.0, 0.00209)), new(0.0056430000000000004d, new GammaParticle(608800.0, 0.00204)), new(0.015903d, new GammaParticle(637300.0, 0.00195)), new(0.0066690000000000004d, new GammaParticle(665100.0, 0.00186)), new(0.08310600000000001d, new GammaParticle(684600.0, 0.00181)), new(0.002565d, new GammaParticle(691700.0, 0.00179)), new(0.0035909999999999996d, new GammaParticle(743100.0, 0.00167)), new(0.012825d, new GammaParticle(754800.0, 0.00164)), new(0.002052d, new GammaParticle(772100.0, 0.00161)), new(0.018468d, new GammaParticle(786300.0, 0.00158)), new(0.0056430000000000004d, new GammaParticle(801200.0, 0.00155)), new(0.018468d, new GammaParticle(819900.0, 0.00151)), new(0.00513d, new GammaParticle(834200.0, 0.00149)), new(0.0035909999999999996d, new GammaParticle(895800.0, 0.00138)), new(0.001539d, new GammaParticle(899500.0, 0.00138)), new(0.00513d, new GammaParticle(913400.0, 0.00136)), new(0.01026d, new GammaParticle(1038000.0, 0.00119)), new(0.017955000000000002d, new GammaParticle(1130600.0, 0.0011)), new(0.006156d, new GammaParticle(1141900.0, 0.00109)), new(0.011286000000000001d, new GammaParticle(1220400.0, 0.00102)), new(0.016416d, new GammaParticle(1258600.0, 0.00099)), new(0.01026d, new GammaParticle(1330300.0, 0.00093)), new(0.0035909999999999996d, new GammaParticle(1455800.0, 0.00085)), new(0.003078d, new GammaParticle(1508600.0, 0.00082)), new(0.0092d, new GammaParticle(3388.0, 0.36595)), new(0.0323d, new GammaParticle(22983.0, 0.05395)), new(0.061d, new GammaParticle(23173.0, 0.0535)), new(0.0169d, new GammaParticle(26184.0, 0.04735)), new(0.02d, new GammaParticle(26381.0, 0.047)), new(0.00308d, new GammaParticle(26641.0, 0.04654)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver117()), new(5.199999999999999e-06d, new GammaParticle(28600.0, 0.04335)), new(0.0028092759816d, new GammaParticle(3218.0, 0.38528)), new(7.554373457902377e-05d, new GammaParticle(21990.0, 0.05638)), new(0.00014240100768901748d, new GammaParticle(22163.0, 0.05594)), new(3.9449112207801334e-05d, new GammaParticle(25030.0, 0.04953)), new(4.631325773195877e-05d, new GammaParticle(25211.0, 0.04918)), new(6.8641455241574325e-06d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    